//
//  ImagesViewController.swift
//  BagelGram
//
//  Created by Aaron Osteraas on 21/11/19.
//  Copyright © 2019 Aaron Osteraas. All rights reserved.
//

import Foundation
import UIKit
import Apollo


class ImagesContoller : UIViewController
{
    let apollo: ApolloClient = {
        let configuration = URLSessionConfiguration.default
        
        let url = URL(string: "http://localhost:5000/graphql")!

        return ApolloClient(
            networkTransport: HTTPNetworkTransport(
                url: url
                
            )
        )
    }()
    
//    func doThing()->[GetImage] {
//        apollo.fetch(query: GetImagesQuery()) { result in
//            guard let data = try? result.get().data else {return}
//            print(data)
//            return data
//        }
//    }
    override func viewDidLoad() {
        apollo.fetch(query: GetImagesQuery()) { result in
            guard let data = try? result.get().data else {return}
            print(data)
            
            
            switch result {
                case.success(let result):
                    print(result)
                case.failure(let error):
                    print(error)
            
            }
        }
    }
}
