//
//  HomeViewController.swift
//  BagelGram
//
//  Created by Aaron Osteraas on 21/11/19.
//  Copyright © 2019 Aaron Osteraas. All rights reserved.
//

import UIKit
import Apollo

class HomeViewController : UIViewController {
    let client = Server.shared.apollo
    
    var watcher: GraphQLQueryWatcher<GetImagesQuery>?
    var images: [GetImagesQuery.Data.GetImage]?
    
    
    override func viewDidLoad() {
        super.viewDidLoad()
//        let vm = HomeViewModel()
//        vm.images.bind {
//            tableView.reload withasd
//        }
    }
    func fetchData() {
        client.watch(query: GetImagesQuery()) { result in
            switch result {
            case .success(let res):
                self.images = res.data?.getImages! as? [GetImagesQuery.Data.GetImage]
            case .failure(let error):
                NSLog("Error while fetching query: \(error.localizedDescription)")
            }
        }
    }
}
