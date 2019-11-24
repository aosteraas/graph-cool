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
    static let shared = Server()
    
    private(set) lazy var apollo = ApolloClient(url: URL(string: "http://localhost:5000/graphql")!)
    
    func getImages() {
        apollo.fetch(query: GetImagesQuery()) { result in
            guard let data = try? result.get().data else { return }
            
            if let stuff = data.getImages?.compactMap({$0}) {
                // what to do
                // TODO
            }
        }
    }
    
//    func imagesAlt() -> GetImagesQuery.Data {
//        
//        apollo.fetch(query: GetImagesQuery()) { result in
//            guard let data = try? result.get().data else { return }
//            
//            switch result {
//                case.success(let result):
//                    print(result)
//             return result
//                case.failure(let error):
//                    print(error)
//
//            }
//        }
//    }
//
//    func getImages() -> Observable<GetImagesQuery.Data> {
//             apollo.fetch(query: GetImagesQuery()) { result in
//               guard let data = try? result.get().data else { return }
//               self.imageData = data
//               switch result {
//                   case.success(let result):
//                       print(result)
//                return result
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
