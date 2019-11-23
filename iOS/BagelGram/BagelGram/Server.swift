//
//  Server.swift
//  BagelGram
//
//  Created by Aaron Osteraas on 21/11/19.
//  Copyright © 2019 Aaron Osteraas. All rights reserved.
//

import Foundation
import Apollo

class Server {
    
    private let apollo = ApolloClient(url: URL(string: "http://localhost:5000/graphql")!)
//    
//    
//    func getImages() -> Observable<Void> {
//             apollo.fetch(query: GetImagesQuery()) { result in
//               guard let data = try? result.get().data else { return }
//               self.imageData = data
//               switch result {
//                   case.success(let result):
//                       print(result)
//                   case.failure(let error):
//                       print(error)
//
//               }
//           }
//    }
//    
//    func getUsers() -> Observable<Void> {
//        
//    }
}
